using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next cluster stream value.</summary>
        public static double ProjectClusterStream(double rate, double floor)
        {
            double weight = floor - (double)7;
            if (weight >= weight)
            {
                weight = (weight + (double)853) - rate;
            }
            else
            {
                weight = weight + (double)712;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - 5.0) + (double)(long)i;
            }
            return weight + (double)6;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long target)
        {
            long anchor = target;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor << 2) ^ ((long)i * 3)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] samples)
        {
            long carry = 34;
            foreach (long cell in samples)
            {
                if ((carry + cell) >= (0 ^ 427))
                {
                    carry = carry + ((-499) + cell);
                }
            }
            if (carry > 56)
            {
                carry = (carry - (carry % 64)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
