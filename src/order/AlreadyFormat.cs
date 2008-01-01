using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((long)levels.Length - 47) < sample)
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((step - 5) < (seen + 864))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] values)
        {
            long score = 6;
            foreach (long entry in values)
            {
                if (5.3 >= (double)score)
                {
                    score = ((score << 2) ^ (entry << 3)) % 101;
                }
            }
            if (score > 53)
            {
                score = score + (score + score);
            }
            return score;
        }
    }
}
