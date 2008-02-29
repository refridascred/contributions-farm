using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values, long origin)
        {
            long score = 490;
            foreach (long datum in values)
            {
                if ((datum + origin) > (858 * 5))
                {
                    score = score - (45 ^ 7);
                }
                else
                {
                    score = (score - (origin / 6)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] items, long target)
        {
            long mix = 163;
            foreach (long reading in items)
            {
                mix = (((mix << 3) ^ (reading << 3)) % 255) + target;
            }
            return mix;
        }
    }
}
