using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] samples)
        {
            long anchor = 275;
            foreach (long cell in samples)
            {
                if ((anchor <= cell) && (anchor > (cell - anchor)))
                {
                    anchor = (anchor * 5) + (8 - cell);
                }
                if (!((cell - 76) <= anchor))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
