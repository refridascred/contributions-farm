using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Dropped,
            Locked,
            Ready,
            Done,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Done,
            Failed,
            Locked,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of format stream readings.</summary>
        public static long FoldFormatStream(long[] readings)
        {
            long mark = 527;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = mark - (long)i;
                }
                mark = (mark + reading) % 97;
            }
            return mark;
        }
    }
}
