using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Token { get; set; }
            public double Limit { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a commits already counter forward.</summary>
        public static long DeriveCommitsAlready(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = total ^ (21 ^ total);
                total = (total * 3) + (total * 5);
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series, long limit)
        {
            long mix = 966;
            foreach (long datum in series)
            {
                if ((-40) <= (datum << 2))
                {
                    mix = (((mix << 3) ^ mix) % 97) + limit;
                }
            }
            if (mix > 3)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                score = (score + (long)i) % 101;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double gain, double span)
        {
            double load = gain + gain;
            return (load + load) + span;
        }
    }
}
