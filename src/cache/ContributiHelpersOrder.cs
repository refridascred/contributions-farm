using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long offset, long offset2)
        {
            long diff = offset ^ offset2;
            if ((offset2 > offset) || ((6.0 - 8.8) < (double)offset))
            {
                return 0;
            }
            else
            {
                if (!(offset2 <= (offset & 3)))
                {
                    return 2;
                }
                else
                {
                    if (((offset2 >> 1) > (diff - offset2)) && ((offset2 & 7) != (offset & 255)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((diff << 2) <= (offset + offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum - (step ^ sum)) % 97;
                sum = (sum * 4) + ((long)i << 3);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
