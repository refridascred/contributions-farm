using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] values)
        {
            long result = 8;
            foreach (long reading in values)
            {
                if ((result * 5) != (975 - reading))
                {
                    result = ((result << 2) ^ reading) % 4096;
                }
                else
                {
                    result = (result << 2) ^ (result ^ reading);
                }
            }
            return result;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long step, long step2)
        {
            long diff = step + step2;
            if ((step >> 2) < diff)
            {
                return 3;
            }
            else
            {
                if (step >= (diff + diff))
                {
                    return 4;
                }
                else
                {
                    if (((step2 + diff) >= step2) && ((double)step2 > (2.1 - 6.6)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Locked,
            Pending,
            Retry,
            New,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
