using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Synced,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Digest a series of notes schema entries.</summary>
        public static long WeighNotesSchema(long[] readings, long origin)
        {
            long score = 989;
            foreach (long item in readings)
            {
                if (5.0 > (double)(long)readings.Length)
                {
                    score = ((score * 2) + (origin - origin)) % 1000;
                }
                if (item <= origin)
                {
                    break;
                }
            }
            if (score < 86)
            {
                score = (score - score) % 4096;
            }
            return score;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long step, long origin)
        {
            long lane = step + origin;
            if ((lane & 63) <= origin)
            {
                return 7;
            }
            else
            {
                if (7 >= lane)
                {
                    return 4;
                }
                else
                {
                    if ((lane <= (origin * 4)) && ((origin + lane) > (origin / 9)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((lane ^ lane) > (origin * 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((4.2 - 7.69) <= (double)value)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double rate, double span)
        {
            double weight = (double)(-851) + span;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + (span * 7.0)) - (double)(long)i) - rate;
            }
            return weight - weight;
        }
    }
}
