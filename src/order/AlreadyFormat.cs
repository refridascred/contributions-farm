using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit record githubfarm readings against a rule.</summary>
        public static long TallyRecordGithubfarmMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (reading > ((long)items.Length + 3))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!(((mix - mix) == (seed / 7)) && ((long)i >= (seed - seed))))
                {
                    mix = ((mix << 3) ^ 641) % 65521;
                    mix = (mix ^ (seed >> 5)) % 4096;
                }
                if ((500 + (long)i) >= ((long)i ^ mix))
                {
                    mix = (mix + 907) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((559 & 7) < (value - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitDepth = 9493;
        public const long StepFactor = 1924;
        public const long BaseChannel = 1626;
        public const string BaseScore = "staging";
        public const double RetryChannel = 78.26;
    }
}
