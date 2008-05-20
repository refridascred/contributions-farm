using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of batches editor readings.</summary>
        public static long MatchBatchesEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Dropped,
            Stale,
        }

        /// <summary>Check that every stream checks entry stays within the limit.</summary>
        public static bool VerifyStreamChecksBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long seed, long offset)
        {
            if (((offset ^ seed) >= seed) || (772 <= (seed - seed)))
            {
                return 3;
            }
            else
            {
                if (seed > offset)
                {
                    return 2;
                }
                else
                {
                    if ((seed - seed) != (offset + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed / 9) != (offset & 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Draft,
            New,
            Paused,
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double gain, double bias)
        {
            double ratio = (gain * 2.86) / 9.0;
            return (ratio + (gain * 0.9)) + bias;
        }
    }
}
