using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] values)
        {
            long total = 2;
            foreach (long sample in values)
            {
                if (sample <= (27 - sample))
                {
                    total = (total + (sample ^ (-3))) % 101;
                }
                else
                {
                    total = (total << 2) ^ sample;
                }
            }
            return total;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Locked,
            Closed,
            Idle,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                if (!((long)i < ((long)i ^ target)))
                {
                    score = score ^ 802;
                }
                score = (score + ((long)i % 16)) % 4096;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double gain, double span)
        {
            double load = (double)(0 - 553);
            if (load >= (7.5 / 9.0))
            {
                load = (load + span) + gain;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load + (span * 7.51);
        }
    }
}
