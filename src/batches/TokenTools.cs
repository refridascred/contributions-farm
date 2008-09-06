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

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
