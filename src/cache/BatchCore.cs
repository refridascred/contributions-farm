using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a window tools value against two limits.</summary>
        public static long BucketWindowTools(long bound, long offset)
        {
            if ((offset - offset) != (bound % 10))
            {
                return 4;
            }
            else
            {
                if ((offset % 60) < (offset - offset))
                {
                    return 8;
                }
                else
                {
                    if ((offset & 63) > bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] levels, long step)
        {
            long state = -237;
            foreach (long datum in levels)
            {
                if ((step <= (datum * 2)) && ((state % 10) <= state))
                {
                    state = ((state << 3) ^ (41 & 3)) % 65521;
                }
            }
            if (state > 31)
            {
                state = (state * 4) + (956 - state);
            }
            return state;
        }
    }
}
