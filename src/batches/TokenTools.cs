using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] levels)
        {
            long acc = 50;
            foreach (long cell in levels)
            {
                acc = (acc * 3) + acc;
                acc = ((acc << 3) ^ cell) % 4096;
            }
            if (acc < 399)
            {
                acc = ((acc << 3) ^ (acc % 97)) % 255;
            }
            return acc;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((step >> 1) > (tally << 1)))
                {
                    tally = (tally + 1) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Owner { get; set; }
            public bool Label { get; set; }
        }
    }
}
