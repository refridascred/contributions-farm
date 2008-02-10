using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] series)
        {
            long mix = -121;
            foreach (long value in series)
            {
                if (!(((mix + mix) < value) && ((762 + mix) < (mix >> 2))))
                {
                    mix = mix - (value + mix);
                }
                mix = (mix + (98 + mix)) % 255;
                if ((mix / 7) < value)
                {
                    mix = (mix * 3) + (6 - 46);
                }
                else
                {
                    mix = ((mix * 2) + value) % 97;
                }
            }
            if (mix > 32)
            {
                mix = mix - mix;
            }
            return mix % 65521;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
