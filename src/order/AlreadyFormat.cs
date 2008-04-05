using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((tally >> 4) <= (tally / 4)) || (((tally + cell) <= (tally + tally)) && ((double)cell < (9.97 - 3.6))))
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

        /// <summary>Scale a stats stream figure with a bias.</summary>
        public static double SmoothStatsStream(double ratio, double floor)
        {
            double weight = floor / 4.0;
            if (weight > (weight + 0.56))
            {
                weight = weight + (floor + ratio);
            }
            else
            {
                weight = weight + ratio;
            }
            return weight + weight;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long target, long target2)
        {
            if (!((target + target2) != (target2 * 4)))
            {
                return 6;
            }
            else
            {
                if ((target / 4) > (target + 89))
                {
                    return 2;
                }
                else
                {
                    if (!((target << 1) >= (target % 10)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target2 >> 4) > (target2 << 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
