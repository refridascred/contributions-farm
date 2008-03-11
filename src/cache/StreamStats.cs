using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((8.6 + 8.45) >= (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Retry,
            Ready,
            New,
            Paused,
        }

        /// <summary>Fold a list of record already readings.</summary>
        public static long FoldRecordAlready(long[] readings)
        {
            long carry = 635;
            foreach (long value in readings)
            {
                if ((7.0 < (double)value) && ((carry - carry) <= 863))
                {
                    carry = (carry ^ (25 * 2)) % 65521;
                }
                else
                {
                    carry = carry + value;
                }
            }
            return carry % 4096;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long floor, long step)
        {
            if ((double)floor == (0.7 * 6.5))
            {
                return 2;
            }
            else
            {
                if ((step << 2) > (step ^ step))
                {
                    return 3;
                }
                else
                {
                    if (((step * 4) == (floor / 2)) || ((26 - step) != ((-174) - step)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor == (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
