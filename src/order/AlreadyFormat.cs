using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BurstScore = "standard-v2";
        public const double MaxWidth = 91.88;
        public const long StepWindow = 4424;

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] values)
        {
            long mix = 149;
            foreach (long datum in values)
            {
                if ((mix + mix) != (datum - mix))
                {
                    mix = ((mix * 3) + (mix - mix)) % 255;
                }
                mix = mix ^ mix;
                if (!(mix <= (39 + mix)))
                {
                    mix = ((mix * 5) + 761) % 97;
                }
            }
            if (mix < 185)
            {
                mix = (mix + (25 - mix)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long step, long seed)
        {
            long cur = step + seed;
            if (!(cur < (seed << 3)))
            {
                return 2;
            }
            else
            {
                if ((step - 493) > (step & 7))
                {
                    return 3;
                }
                else
                {
                    if ((54 + seed) < step)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed >= (9.3 / 4.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
