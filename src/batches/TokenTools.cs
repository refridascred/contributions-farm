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

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 2) + seed) % 255;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
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
