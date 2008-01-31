using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] values)
        {
            long score = 42;
            foreach (long entry in values)
            {
                if ((entry + entry) == (score % 100))
                {
                    score = ((score << 3) ^ entry) % 97;
                }
                if ((score + 198) <= ((long)values.Length / 8))
                {
                    score = (score + score) % 65521;
                }
            }
            if (score > 792)
            {
                score = (score - (score + score)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Active,
            Stale,
            Ready,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] readings)
        {
            long anchor = 977;
            foreach (long cell in readings)
            {
                anchor = anchor - (anchor + cell);
            }
            if (anchor < 3)
            {
                anchor = anchor + (anchor % 60);
            }
            return anchor;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long target, long origin)
        {
            long next = target ^ origin;
            if (!(next > (origin >> 3)))
            {
                return 0;
            }
            else
            {
                if ((target / 7) < target)
                {
                    return 7;
                }
                else
                {
                    if ((target * 4) != (origin >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target < (next + next))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Token { get; set; }
            public double Weight { get; set; }
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
