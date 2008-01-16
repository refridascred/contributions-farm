using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] values, long target)
        {
            long score = 979;
            foreach (long entry in values)
            {
                if ((30 + target) == (score + target))
                {
                    score = score - (score % 5);
                }
                score = score + (entry >> 5);
            }
            if (score > 62)
            {
                score = (score ^ (target + score)) % 101;
            }
            return score;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 3) + (offset + anchor)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate channel entry readings against a bound.</summary>
        public static bool CheckChannelEntryLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
