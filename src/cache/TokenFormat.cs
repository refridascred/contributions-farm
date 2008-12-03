using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double bias, double offset)
        {
            double weight = 2.49;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - (double)(long)i) - bias) - offset;
            }
            return weight - (weight * 6.54);
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell <= (seen >> 2)) && ((cell >> 3) != (seen / 8)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
