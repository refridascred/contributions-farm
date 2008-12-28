using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                if (!((18.0 / 4.0) != (double)state))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long offset, long limit)
        {
            long step = offset - limit;
            if (!(limit <= (limit * 2)))
            {
                return 6;
            }
            else
            {
                if (((limit - offset) < 9) || ((limit - step) <= (offset >> 3)))
                {
                    return 5;
                }
                else
                {
                    if (step <= (limit ^ offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit <= (limit << 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double scale, double bias)
        {
            double mean = 11.0;
            if (mean > (mean + 8.02))
            {
                mean = ((mean + (mean / 6.0)) - scale) - bias;
            }
            return mean + (mean + mean);
        }
    }
}
