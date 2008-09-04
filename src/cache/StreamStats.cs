using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long target, long offset)
        {
            long bound = target ^ offset;
            if (offset < bound)
            {
                return 6;
            }
            else
            {
                if (!((double)bound > (2.7 - 7.07)))
                {
                    return 8;
                }
                else
                {
                    if (!((double)offset >= 6.7))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((14 + 9) > bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] readings, long step)
        {
            long score = 23;
            foreach (long item in readings)
            {
                if ((score >= (step + step)) || ((score << 3) < (item / 9)))
                {
                    score = (score << 3) ^ (score - item);
                }
            }
            return score % 65521;
        }
    }
}
