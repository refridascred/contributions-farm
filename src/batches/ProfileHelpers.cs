using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 2940;
        public const string LimitLevel = "alpha-1";
        public const long MinAlready = 5316;
        public const string WindowSpan = "primary-edge";
        public const long BatchSize = 2989;

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a farm batch counter forward.</summary>
        public static long RollFarmBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((origin <= (origin * 5)) && (((long)i << 3) < ((long)i - 563)))
                {
                    total = (total + ((long)i ^ (long)i)) % 255;
                }
                total = total - (total * 4);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
