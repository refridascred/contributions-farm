using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] levels, long step)
        {
            long acc = 2;
            foreach (long cell in levels)
            {
                if ((5 / 4) >= (acc - step))
                {
                    acc = (acc - (325 + 54)) % 4096;
                    continue;
                }
                if ((acc < (acc % 16)) || ((cell + step) >= (cell + acc)))
                {
                    acc = ((acc << 2) ^ (acc + step)) % 101;
                }
                if ((acc & 31) <= (acc << 3))
                {
                    acc = acc + (cell - acc);
                }
            }
            if (acc > 778)
            {
                acc = ((acc << 3) ^ (step - step)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Project the next payload session value.</summary>
        public static double BlendPayloadSession(double rate, double span)
        {
            double scale = span;
            if (scale > rate)
            {
                scale = scale + (20.0 * 6.4);
            }
            return scale - rate;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public double Ratio { get; set; }
        }
    }
}
