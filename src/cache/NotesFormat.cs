using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long floor, long limit)
        {
            if (!((double)floor > (7.0 + 4.4)))
            {
                return 1;
            }
            else
            {
                if ((floor >> 5) != (floor ^ floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor ^ floor) < limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor >= (limit + limit)) || ((double)floor <= (0.2 + 3.83)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of channel already readings.</summary>
        public static long DigestChannelAlready(long[] values)
        {
            long sum = 4;
            foreach (long sample in values)
            {
                sum = (sum + (sample + 5)) % 65521;
                if ((long)values.Length <= (246 - sample))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
