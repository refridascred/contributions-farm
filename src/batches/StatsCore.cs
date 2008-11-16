using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long limit, long limit2)
        {
            long slot = limit - limit2;
            if (limit > slot)
            {
                return 2;
            }
            else
            {
                if ((limit >= (limit2 & 255)) || ((double)limit < (3.0 - 8.0)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value & 127) == ((long)data.Length * 2))
                {
                    matches = (matches + 1) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchScore = 2203;
        public const string MinGraph = "legacy-edge";
        public const long BatchGraph = 1190;
        public const long StepGraph = 7655;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((-8) <= (carry - floor)) && ((floor ^ 588) >= (-386)))
                {
                    carry = (carry + (carry - floor)) % 65521;
                }
                else
                {
                    carry = (carry + (floor & 7)) % 255;
                }
                if (carry >= (473 ^ carry))
                {
                    carry = ((carry << 2) ^ (floor ^ 85)) % 1000;
                    carry = carry + (carry + carry);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            Locked,
            Failed,
            Pending,
            Idle,
        }
    }
}
