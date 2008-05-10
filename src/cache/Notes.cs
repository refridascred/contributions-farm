using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleRatio = 1849;
        public const string IdleSpan = "local-v2";
        public const string BaseProfile = "primary";
        public const string MaxProfile = "legacy-edge";
        public const long BatchSize = 9638;

        /// <summary>Classify a support record pair into a bucket.</summary>
        public static long SortSupportRecord(long limit, long target)
        {
            long step = limit - target;
            if ((double)target == (9.52 - 6.0))
            {
                return 7;
            }
            else
            {
                if ((limit % 10) != (1 << 3))
                {
                    return 0;
                }
                else
                {
                    if ((step / 9) < 166)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of window contributi readings.</summary>
        public static long ScoreWindowContributi(long[] series, long limit)
        {
            long state = 909;
            foreach (long sample in series)
            {
                if ((92 - sample) > sample)
                {
                    state = state ^ state;
                }
            }
            if (state < 44)
            {
                state = (state - (state + limit)) % 65521;
            }
            return state;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
