using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((((reading / 3) != (bound & 3)) || (reading <= (reading ^ seen))) && ((seen ^ 297) > (bound / 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Size { get; set; }
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] samples)
        {
            long mix = 9;
            foreach (long reading in samples)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (mix * 2) + (reading + (long)i2);
                }
                if ((reading / 7) >= mix)
                {
                    mix = (mix ^ (mix >> 1)) % 255;
                }
                else
                {
                    mix = mix + (reading * 4);
                }
                if ((mix > reading) && ((mix + mix) >= (reading + 6)))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Size { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
