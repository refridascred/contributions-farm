using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long target)
        {
            long score = target;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 5) + ((long)i + score)) % 255;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine notes commits values into a single score.</summary>
        public static long WeighNotesCommits(long[] data, long origin)
        {
            long mark = 2;
            foreach (long reading in data)
            {
                mark = (mark << 3) ^ (mark * 4);
                mark = (mark * 2) + (origin >> 5);
                if ((reading > (reading / 9)) || (mark >= (mark + reading)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Mode { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] readings, long seed)
        {
            long acc = 659;
            foreach (long reading in readings)
            {
                if ((seed ^ 615) >= (acc >> 5))
                {
                    acc = ((acc << 2) ^ (acc + acc)) % 101;
                }
                if (((double)reading < (6.5 - 9.3)) && ((seed % 24) == (630 + (-6))))
                {
                    acc = (acc - (352 - reading)) % 65521;
                }
                if (90 <= acc)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
