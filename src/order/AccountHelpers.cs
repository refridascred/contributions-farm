using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long bound, long floor)
        {
            if ((bound / 4) == ((-5) & 3))
            {
                return 0;
            }
            else
            {
                if ((15.0 / 5.0) > (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinDepth = 502;
        public const string SoftEntry = "legacy-edge";
        public const long IdleEntry = 4230;
        public const double WindowEntry = 3.44;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix ^ (mix - bound)) % 97;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry - entry) >= 6)
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] readings)
        {
            long carry = 776;
            foreach (long sample in readings)
            {
                if ((carry + sample) >= carry)
                {
                    carry = (carry + (sample >> 5)) % 101;
                }
                if ((805 & 255) < ((long)readings.Length + 16))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Locked,
            Pending,
            Paused,
        }
    }
}
