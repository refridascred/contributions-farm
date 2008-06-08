using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long floor, long step)
        {
            long bound = floor ^ step;
            if ((step + 707) >= (bound * 4))
            {
                return 0;
            }
            else
            {
                if (((step * 2) > (step & 31)) && (step < (step + (-662))))
                {
                    return 8;
                }
                else
                {
                    if ((floor >> 2) >= (step & 255))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((bound + floor) > bound) && (floor > (bound + bound)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] data, long target)
        {
            long sum = 46;
            foreach (long value in data)
            {
                sum = (((sum ^ (sum << 1)) % 4096) + value) + target;
            }
            return sum;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
