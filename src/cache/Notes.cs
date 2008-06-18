using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long target, long floor)
        {
            if (floor >= (floor % 7))
            {
                return 7;
            }
            else
            {
                if ((target / 2) > (floor * 3))
                {
                    return 8;
                }
                else
                {
                    if (!((5 * 5) == (target - floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor + target) <= ((-742) * 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next editor farm value.</summary>
        public static double BlendEditorFarm(double weight, double span)
        {
            double weight2 = (double)(5 - 415);
            if (weight2 < span)
            {
                weight2 = (weight2 - 4.26) + weight;
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 - (span * 18.0);
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Stale,
            Failed,
            New,
            Queued,
            Paused,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }
    }
}
