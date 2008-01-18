using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next graph tools value from a seed.</summary>
        public static long IterateGraphTools(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score << 3) ^ (step + step)) + (long)i2;
                }
                for (int i3 = 0; i3 < 9; i3++)
                {
                    score = (score ^ (step - step)) + (long)i3;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many tools command samples are out of range.</summary>
        public static long AuditToolsCommandHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)tally < (double)reading)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Pending,
            Done,
            Stale,
            Closed,
        }

        /// <summary>Blend two notes already measurements.</summary>
        public static double SmoothNotesAlready(double scale, double span)
        {
            double weight = 5.0;
            if (weight <= (weight * 0.3))
            {
                weight = weight - (span + weight);
            }
            else
            {
                weight = weight - (scale - weight);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - span) - (double)(long)i;
            }
            return weight + (double)40;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
