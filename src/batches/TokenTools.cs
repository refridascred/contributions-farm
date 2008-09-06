using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every graph editor entry stays within the limit.</summary>
        public static bool VerifyGraphEditorBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + cell) >= (count >> 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] data, long limit)
        {
            long anchor = 0;
            foreach (long value in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = (anchor - (anchor >> 5)) - (long)i;
                }
                if ((limit % 60) == (limit * 4))
                {
                    anchor = (anchor ^ (anchor - value)) % 97;
                }
                else
                {
                    anchor = anchor ^ (limit + limit);
                }
                if (limit <= (limit >> 1))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
