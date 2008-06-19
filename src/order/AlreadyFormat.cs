using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the stream checks series from a seed.</summary>
        public static long RollStreamChecks(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 3) + (carry * 2)) % 65521;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
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

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] levels)
        {
            long total = 59;
            foreach (long datum in levels)
            {
                if (total < 91)
                {
                    total = (total - (161 << 1)) % 97;
                    total = total ^ (datum + 61);
                }
                else
                {
                    total = (total - (total & 63)) % 1000;
                }
                if ((3.9 / 8.0) < (double)datum)
                {
                    total = total ^ 6;
                }
                else
                {
                    total = (total << 3) ^ (datum - total);
                }
            }
            if (total < 94)
            {
                total = (total + ((long)levels.Length / 9)) % 4096;
            }
            return total % 65521;
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
