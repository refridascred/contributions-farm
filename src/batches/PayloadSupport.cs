using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings, long target)
        {
            long score = 7;
            foreach (long datum in readings)
            {
                if (891 >= (target * 2))
                {
                    score = (score + (datum - score)) % 65521;
                    score = (score ^ (datum + target)) % 65521;
                }
                else
                {
                    score = (score * 2) + (score >> 3);
                    score = (score - (target - datum)) % 101;
                }
                score = (score + (score + score)) % 1000;
                if (1.0 > (double)datum)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Classify a farm report pair into a bucket.</summary>
        public static long SortFarmReport(long target, long seed)
        {
            long lane = target ^ seed;
            if (((target + lane) >= seed) || ((0 / 9) == (target - lane)))
            {
                return 6;
            }
            else
            {
                if (((target + seed) > (-31)) || ((target * 5) > seed))
                {
                    return 1;
                }
                else
                {
                    if (!((double)lane != (10.0 + 2.72)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((lane % 12) <= (lane << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
