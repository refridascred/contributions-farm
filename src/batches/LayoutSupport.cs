using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Queued,
            New,
            Ready,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long origin, long step)
        {
            if (step < (origin >> 2))
            {
                return 4;
            }
            else
            {
                if ((1.41 / 8.0) != (double)step)
                {
                    return 1;
                }
                else
                {
                    if (step <= (step * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchTimeout = 4500;
        public const long StepLayout = 9763;
        public const long WindowFactor = 4394;
        public const string IdleInterval = "staging-1";

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long target)
        {
            long total = target;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i ^ 41) < (target + target))
                {
                    total = (total - (total + total)) % 65521;
                }
                if ((long)i >= target)
                {
                    total = (total - (total * 5)) % 65521;
                }
                else
                {
                    total = ((total * 3) + (total ^ target)) % 4096;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
