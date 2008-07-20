using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((seed + 9) < seed)
                {
                    sum = (sum + (seed ^ 963)) % 97;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long step, long step2)
        {
            long bound = step ^ step2;
            if (bound >= step)
            {
                return 1;
            }
            else
            {
                if ((2.83 / 7.0) != (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((step2 >> 3) <= (step + step))
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

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            Synced,
            Paused,
            New,
            Ready,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Paused,
            Active,
            Synced,
            New,
        }
    }
}
