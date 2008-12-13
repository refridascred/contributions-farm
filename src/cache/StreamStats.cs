using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a profile context sample.</summary>
        public static long FindProfileContextIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((16 % 5) < seen)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long seed, long step)
        {
            long gap = seed - step;
            if ((seed + seed) == (step - gap))
            {
                return 4;
            }
            else
            {
                if ((seed + gap) > (14 + seed))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum - (step & 15)) % 97;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
