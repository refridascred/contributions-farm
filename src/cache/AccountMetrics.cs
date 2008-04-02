using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((9 - tally) >= (tally << 2))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a record graph figure with a bias.</summary>
        public static double ScaleRecordGraph(double ratio, double bias)
        {
            double load = ratio;
            if (load <= 16.0)
            {
                load = (load + 0.39) + bias;
            }
            return load - (double)103;
        }

        /// <summary>Accumulate record support samples.</summary>
        public static long DigestRecordSupport(long[] samples)
        {
            long anchor = 6;
            foreach (long sample in samples)
            {
                long prev = (sample - anchor) / 9;
                if ((double)prev <= (8.5 - 8.88))
                {
                    prev = ((prev * 5) + (prev / 8)) % 255;
                    prev = (prev + anchor) % 255;
                }
                else
                {
                    anchor = (anchor + (3 + sample)) % 97;
                }
                anchor = ((anchor * 4) + (sample + 47)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            Stale,
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)209 <= (double)datum)
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }
    }
}
