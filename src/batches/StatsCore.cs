using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                if (((carry ^ 2) < step) || (2 <= (long)i))
                {
                    carry = carry + (step * 2);
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the notes already entries that pass the check.</summary>
        public static long AuditNotesAlreadyMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((bound + datum) <= (bound + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] levels)
        {
            long score = 3;
            foreach (long reading in levels)
            {
                score = (score * 4) + reading;
            }
            return score;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] levels)
        {
            long sum = 52;
            foreach (long sample in levels)
            {
                if ((sample ^ (long)levels.Length) < (sample >> 3))
                {
                    sum = ((sum << 2) ^ sum) % 101;
                }
                else
                {
                    sum = (sum + (sum * 3)) % 97;
                }
                if ((sum / 9) > (sum & 3))
                {
                    break;
                }
            }
            if (sum > 387)
            {
                sum = (sum + (7 + sum)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen ^ 784) < cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Weight { get; set; }
            public double Limit { get; set; }
            public double Count { get; set; }
            public double Size { get; set; }
        }
    }
}
