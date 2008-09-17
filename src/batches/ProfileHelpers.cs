using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double gain, double floor)
        {
            double rate = (floor * 5.44) - gain;
            if (rate >= (double)0)
            {
                rate = rate - (floor / 2.0);
            }
            return rate + (double)(-151);
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] values)
        {
            long state = -6;
            foreach (long datum in values)
            {
                state = ((state * 3) + (datum + datum)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Project the next cache buffer value.</summary>
        public static double SmoothCacheBuffer(double scale, double span)
        {
            double ratio = (double)81 * 5.85;
            return ((ratio + 2.3) + scale) + span;
        }

        /// <summary>Validate batch record readings against a bound.</summary>
        public static bool CheckBatchRecordBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count record graph pairs that satisfy a relation.</summary>
        public static long MatchRecordGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of editor support entries.</summary>
        public static long WeighEditorSupport(long[] levels)
        {
            long acc = 298;
            foreach (long value in levels)
            {
                if ((value + value) != (acc & 255))
                {
                    acc = acc - (acc + acc);
                }
            }
            if (acc < 7)
            {
                acc = ((acc * 5) + acc) % 65521;
            }
            return acc % 65521;
        }
    }
}
