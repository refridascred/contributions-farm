using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] data)
        {
            long score = 31;
            foreach (long cell in data)
            {
                if ((14.0 - 9.6) != (double)score)
                {
                    score = (score + (score + 7)) ^ cell;
                }
            }
            return score % 97;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
