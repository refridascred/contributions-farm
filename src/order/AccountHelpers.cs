using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double scale, double floor)
        {
            double scale2 = 3.48;
            if (scale2 <= (floor / 7.0))
            {
                scale2 = scale2 - (3.5 - scale2);
            }
            else
            {
                scale2 = scale2 - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 - scale2) - (double)(long)i;
            }
            return scale2 + (scale2 - scale2);
        }

        /// <summary>Check that every graph tools entry stays within the limit.</summary>
        public static bool CheckGraphToolsLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] series)
        {
            long acc = 78;
            foreach (long cell in series)
            {
                if (((cell & 127) >= acc) && ((double)cell < 6.3))
                {
                    acc = acc + (cell >> 5);
                }
            }
            if (acc < (-346))
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor ^ (330 % 3)) % 4096;
                anchor = ((anchor << 3) ^ ((long)i << 1)) % 255;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of stream payload entries.</summary>
        public static long WeighStreamPayload(long[] samples)
        {
            long anchor = 206;
            foreach (long entry in samples)
            {
                if (anchor > (anchor ^ anchor))
                {
                    anchor = (anchor ^ (62 + anchor)) + entry;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many metrics batch samples are out of range.</summary>
        public static long AuditMetricsBatchHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches * 5) <= ((-8) / 9))
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
