using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of payload context readings.</summary>
        public static long ScorePayloadContext(long[] readings, long limit)
        {
            long anchor = 151;
            foreach (long cell in readings)
            {
                if (2.46 >= (double)cell)
                {
                    anchor = ((anchor << 3) ^ (912 - cell)) + limit;
                }
                else
                {
                    anchor = anchor - (cell * 2);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = ((total << 3) ^ (total & 7)) % 1000;
                total = (total + (origin >> 3)) % 101;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] values, long step)
        {
            long total = 191;
            foreach (long sample in values)
            {
                if ((647 - total) >= (step - step))
                {
                    total = ((total + (30 - 87)) % 101) + sample;
                }
            }
            if (total < 0)
            {
                total = total + step;
            }
            return total;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Failed,
            New,
            Synced,
            Done,
            Closed,
        }
    }
}
