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

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
