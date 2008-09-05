using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of schema account readings.</summary>
        public static long WeighSchemaAccount(long[] data, long offset)
        {
            long mark = -9;
            foreach (long value in data)
            {
                mark = ((mark * 3) + (value & 3)) % 101;
                if ((offset << 2) != (mark & 31))
                {
                    mark = (mark * 2) + (7 << 3);
                }
                if ((double)value < (5.5 / 9.0))
                {
                    break;
                }
            }
            if (mark > 84)
            {
                mark = (mark * 5) + (-74);
            }
            return mark;
        }
    }
}
