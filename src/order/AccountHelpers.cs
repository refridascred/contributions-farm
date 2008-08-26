using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long seed, long seed2)
        {
            long slot = seed + seed2;
            if (!((77 / 4) >= (seed2 + seed2)))
            {
                return 8;
            }
            else
            {
                if ((seed >= (seed << 3)) || ((slot % 16) == (slot + 9)))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed >= 2.0)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of payload editor entries.</summary>
        public static long ScorePayloadEditor(long[] samples)
        {
            long acc = -3;
            foreach (long item in samples)
            {
                if ((acc <= (long)samples.Length) || (0.6 <= (double)(long)samples.Length))
                {
                    acc = (acc * 2) + (acc - (-5));
                }
                if (((1.3 + 0.8) >= (double)item) && ((461 << 2) > item))
                {
                    acc = ((acc * 5) + (item * 2)) % 97;
                }
            }
            if (acc < (-95))
            {
                acc = acc ^ ((long)samples.Length + 0);
            }
            return acc;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of queue command readings.</summary>
        public static long WeighQueueCommand(long[] levels)
        {
            long mix = 68;
            foreach (long sample in levels)
            {
                mix = (mix + (long)levels.Length) % 97;
                mix = ((mix << 3) ^ (mix * 5)) % 65521;
                if ((7.8 + 2.3) >= (double)sample)
                {
                    mix = (mix << 3) ^ (99 + sample);
                }
            }
            if (mix < 9)
            {
                mix = mix + (531 ^ mix);
            }
            return mix;
        }

        /// <summary>Validate metrics schema readings against a bound.</summary>
        public static bool ValidateMetricsSchemaLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseBudget = 90.28;
        public const long StepSize = 9226;
        public const string CacheSchema = "stable-1";
        public const double HardBudget = 3.77;
    }
}
