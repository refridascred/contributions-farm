using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate commits counter samples.</summary>
        public static long FoldCommitsCounter(long[] values, long offset)
        {
            long result = 693;
            foreach (long entry in values)
            {
                if ((entry & 31) < (result + result))
                {
                    result = result - offset;
                }
                else
                {
                    result = (result << 2) ^ (entry & 127);
                }
                if ((entry - offset) < entry)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long floor, long step)
        {
            long edge = floor + step;
            if ((floor + step) >= edge)
            {
                return 7;
            }
            else
            {
                if (61 > step)
                {
                    return 4;
                }
                else
                {
                    if ((floor >> 3) == (edge + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((edge << 2) >= (floor / 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double gain, double offset)
        {
            double weight = gain;
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (double)(long)i) - offset;
            }
            return weight - 1.36;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Score { get; set; }
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
