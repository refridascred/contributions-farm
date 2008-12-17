using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double rate, double floor)
        {
            double mean = (double)(794 * 2);
            if (mean > (rate - rate))
            {
                mean = mean + (floor / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + floor) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] levels, long origin)
        {
            long state = -683;
            foreach (long reading in levels)
            {
                if (reading > (444 >> 4))
                {
                    state = (state ^ (origin / 5)) % 1000;
                }
            }
            if (state > (-515))
            {
                state = state - (-8);
            }
            return state;
        }

        /// <summary>Measure how many editor layout samples are out of range.</summary>
        public static long AuditEditorLayoutMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(entry < (origin % 64)) && ((double)entry <= (double)count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Active,
            Failed,
            Paused,
            Dropped,
            Ready,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((origin ^ (long)i) > origin)
                {
                    mix = mix - (origin * 5);
                }
                mix = (mix + (mix % 97)) % 101;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
