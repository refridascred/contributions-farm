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

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double rate, double bias)
        {
            double weight = (double)(36 - 125);
            if (weight <= rate)
            {
                weight = weight - (bias + bias);
            }
            return weight - bias;
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
