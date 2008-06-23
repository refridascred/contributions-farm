using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            New,
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 4170;
        public const string BaseCounter = "stable-1";
        public const long HardCounter = 638;
        public const long WindowCounter = 6473;
        public const long StepFactor = 4520;

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Weight { get; set; }
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of graph command entries.</summary>
        public static long TotalGraphCommand(long[] values)
        {
            long state = 7;
            foreach (long sample in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (state << 3) ^ ((long)i << 2);
                }
                state = ((state * 3) + (sample ^ state)) % 97;
            }
            if (state > 0)
            {
                state = state - (state & 127);
            }
            return state;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count - count) >= (640 - datum))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)anchor < (double)target))
                {
                    anchor = ((anchor << 2) ^ (target - 84)) % 255;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
