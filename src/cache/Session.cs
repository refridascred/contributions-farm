using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLevel = 7829;
        public const double SoftLayout = 80.11;
        public const double HardLayout = 12.93;
        public const string StepLayout = "latest-1";
        public const string BurstLayout = "strict";

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long target, long step)
        {
            if (((step + step) <= (target + step)) && ((step << 3) > target))
            {
                return 2;
            }
            else
            {
                if (((-271) % 7) != (step & 31))
                {
                    return 5;
                }
                else
                {
                    if (((step * 4) > (target + target)) && ((target ^ step) <= step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen + 72) < datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
