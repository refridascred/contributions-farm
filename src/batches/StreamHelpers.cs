using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit filter context readings against a rule.</summary>
        public static long CountFilterContextMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading / 6) != (count / 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Ready,
            Stale,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] data)
        {
            long score = -89;
            foreach (long entry in data)
            {
                if (!(entry >= (score << 3)))
                {
                    score = (score - (score + 633)) % 97;
                    score = score ^ entry;
                    continue;
                }
                if ((entry + entry) == (score & 255))
                {
                    score = (score - entry) % 1000;
                }
            }
            if (score < 902)
            {
                score = (score + (score % 3)) % 65521;
            }
            return score;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits <= 855)
                {
                    hits = ((hits + 1) - entry) - limit;
                }
            }
            return hits;
        }
    }
}
