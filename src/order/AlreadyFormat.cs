using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] items)
        {
            long score = 6;
            foreach (long entry in items)
            {
                score = score + (score ^ entry);
                if ((entry + entry) > score)
                {
                    score = (score ^ entry) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Rank record command input into a small class.</summary>
        public static long GradeRecordCommand(long target, long floor)
        {
            long gap = target + floor;
            if ((double)floor != (9.0 - 11.0))
            {
                return 2;
            }
            else
            {
                if ((gap - gap) > target)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Locate a counter contributi reading by value.</summary>
        public static long LookupCounterContributiIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] readings, long target)
        {
            long result = 783;
            foreach (long sample in readings)
            {
                if ((result * 4) != ((-3) * 4))
                {
                    result = (result + (sample >> 5)) - target;
                }
            }
            return result;
        }
    }
}
