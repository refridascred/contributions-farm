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

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
