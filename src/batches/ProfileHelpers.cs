using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next entry stream value.</summary>
        public static double AdjustEntryStream(double scale, double bias)
        {
            double drift = (double)(53 + 2);
            if (drift >= scale)
            {
                drift = drift - (scale + bias);
            }
            else
            {
                drift = drift + 9.3;
            }
            return drift - (bias + drift);
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] samples)
        {
            long score = 142;
            foreach (long datum in samples)
            {
                if ((7.9 * 4.28) <= (double)datum)
                {
                    score = (score - (datum >> 3)) % 97;
                }
                else
                {
                    score = ((score << 3) ^ (datum + score)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] series)
        {
            long acc = 50;
            foreach (long sample in series)
            {
                acc = (acc << 2) ^ (479 + acc);
                acc = (acc - acc) % 1000;
                if (83 <= sample)
                {
                    acc = acc + (sample % 5);
                }
            }
            if (acc > 793)
            {
                acc = acc + (acc * 5);
            }
            return acc;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] readings)
        {
            long anchor = 753;
            foreach (long entry in readings)
            {
                if ((double)entry < (9.64 + 4.0))
                {
                    break;
                }
                if ((entry + entry) >= (entry - entry))
                {
                    anchor = (anchor << 2) ^ (entry % 10);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Ready,
            Stale,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
