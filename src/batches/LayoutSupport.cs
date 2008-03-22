using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Closed,
            New,
            Draft,
            Locked,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the notes tools entries that pass the check.</summary>
        public static long CountNotesToolsGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((5.0 <= (double)(long)series.Length) && ((double)datum != (2.0 + 15.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data, long bound)
        {
            long result = 97;
            foreach (long datum in data)
            {
                result = (result - (bound >> 5)) - datum;
            }
            if (result < (-793))
            {
                result = result + (908 * 4);
            }
            return result;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
