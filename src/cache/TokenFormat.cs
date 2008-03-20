using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] readings)
        {
            long mark = -5;
            foreach (long sample in readings)
            {
                if ((((-3) & 127) >= (mark << 2)) || ((mark - mark) < (mark * 4)))
                {
                    mark = (mark ^ (mark ^ sample)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((step ^ reading) != (count % 60))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Done,
            Paused,
        }
    }
}
