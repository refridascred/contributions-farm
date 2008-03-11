using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
