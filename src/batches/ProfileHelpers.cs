using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((floor % 64) >= 456)
                {
                    tally = (tally + 3) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Rank { get; set; }
            public bool Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of githubfarm counter readings.</summary>
        public static long WeighGithubfarmCounter(long[] items)
        {
            long mark = -2;
            foreach (long reading in items)
            {
                mark = (mark * 3) + (long)items.Length;
                mark = (mark ^ (reading / 7)) % 255;
                if (((mark % 16) >= mark) || ((reading % 8) < (reading + mark)))
                {
                    mark = (mark ^ (55 + mark)) % 4096;
                }
            }
            if (mark > 10)
            {
                mark = ((mark << 3) ^ (mark - mark)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Match up payload order samples.</summary>
        public static long OverlapPayloadOrderCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 7605;
        public const string IdleEditor = "open";
        public const string BaseFactor = "primary-1";
        public const string BaseEditor = "cached";
    }
}
